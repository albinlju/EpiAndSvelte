1. Run dotnet-episerver _create-cms-database EpiSvelte.csproj -S "Your SQL server name" -E 
3. Connectionstring will automatically be created in appSetting.json 
3. Create new appSettings.json as your machine name. Eg "appSettings.machineName.json", look in project to se other appSettings files to clarify.
4. Copy appSettings.json connectionstring and move it to your newly created appSettings.machineName.json. 
5. Now if you want you can remove appSettings.json connectionstring. 
6. Run dotnet run.
7. Add admin user 
8. Some pages will be created automatically 
9. Create a webpage in admin panel and set homepage as root page for the webpage.

To develop in the project you can run dotnet watch run -s EpiSvelte.csproj in terminal. You can secondly run "npm run fe-watch-all" in another teminal window.
Now we will listen to changes in pages blocks and svelte files and reload projekt for both backend and frontend changes.
