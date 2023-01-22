const fs = require("fs");
const path = require("path");
const cp = require('child_process');

const exec = cmd => new Promise(resolve => {
    console.log(cmd);
    let exec = cp.exec(cmd);
    exec.stdout.on("data", data => { if (data) { console.log(data); } });
    exec.stderr.on("data", data => { if (data) { console.error(data); } });
    exec.on("exit", () => resolve());
});

const getAllConfigs = function (dir, result) {
    let files = fs.readdirSync(dir)
    result = result || [];

    files.forEach(file => {
        if (fs.statSync(path.join(dir, file)).isDirectory()) {
            result = getAllConfigs(path.join(dir, file), result)
        } else {
            if (file.endsWith(".rollup.config.js")) {
                result.push("./" + path.join(dir, file).replace(/[\\/]/g, "/"));
            }
        }
    })

    return result;
}

const promises = [];
const build = "./wwwroot/build/";

if (!fs.existsSync(build)) {
    console.log("Creating dir " + build + " ...");
    fs.mkdirSync(build);
} else {
    for (let file of fs.readdirSync(build)) {
        if (file.endsWith(".map")) {
            var name = (build + "/" + file).replace("//", "/");
            console.log("removing ", name);
            try {
                fs.unlinkSync(name)
                //file removed
            } catch (err) {
                console.error(err)
            }
        }
    }
}

promises.push(exec(`npm run fe-scss-watch`));

for (let pageConfigs of getAllConfigs("./Features/Episerver/Pages")) {
    promises.push(exec("npx rollup -c " + pageConfigs + " --bundleConfigAsCjs"));
}

for(let componentsConfigs of getAllConfigs("./Features/Episerver/Components")){
    promises.push(exec("npx rollup -c " + componentsConfigs + " --bundleConfigAsCjs"));
}

for(let MVCComponetsConfigs of getAllConfigs("./Features/MVC/Components")){
    promises.push(exec("npx rollup -c " + MVCComponetsConfigs + " --bundleConfigAsCjs"));
}

for(let blockConfigs of getAllConfigs("./Features/Svelte/Components")){
    promises.push(exec("npx rollup -c " + blockConfigs + " --bundleConfigAsCjs"));
}

console.log("Watching all...");
