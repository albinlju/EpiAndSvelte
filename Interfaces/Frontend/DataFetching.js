/**
 * Enum describing in which mode the Content Delivery API
 * is being used.
 */
export var ContextMode;
(function (ContextMode) {
    /**
     * Default mode, also known as view mode.
     */
    ContextMode["Default"] = "DEFAULT";
    /**
     * Preview mode in the CMS shell.
     */
    ContextMode["Preview"] = "PREVIEW";
    /**
     * Edit mode in the CMS shell.
     */
    ContextMode["Edit"] = "EDIT";
})(ContextMode || (ContextMode = {}));
export var ResolvedContentStatus;
(function (ResolvedContentStatus) {
    /**
     * Content was unsuccessfully resolved due to
     * unknown reasons.
     */
    ResolvedContentStatus["Unknown"] = "UNKNOWN";
    /**
     * Content was successfully resolved.
     */
    ResolvedContentStatus["Resolved"] = "RESOLVED";
    /**
     * Content was not found.
     */
    ResolvedContentStatus["NotFound"] = "NOTFOUND";
    /**
     * Request needs to be authorized to be able to
     * resolve the content.
     */
    ResolvedContentStatus["Unauthorized"] = "UNAUTHORIZED";
    /**
     * Request was authorized but didn't have sufficient
     * access rights to be able to resolve the content.
     */
    ResolvedContentStatus["AccessDenied"] = "ACCESSDENIED";
})(ResolvedContentStatus || (ResolvedContentStatus = {}));
//# sourceMappingURL=DataFetching.js.map