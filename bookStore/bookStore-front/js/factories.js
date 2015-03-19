var standardMethods = {
    'create': { method: 'POST' },
    'index': { method: 'GET', isArray: true },
    'show': { method: 'GET', isArray: false },
    'update': { method: 'PUT' },
    'destroy': { method: 'DELETE' }
};

app.factory("book",["$resource", function ($resource) {
    return $resource("/api/books/:id", { id: "@id" },standardMethods);
}]);

app.factory("author", ["$resource", function ($resource) {
    return $resource("/api/authors/:id", { id: "@id" }, standardMethods);
}]);

app.factory("genre", ["$resource", function ($resource) {
    return $resource("/api/genres/:id", { id: "@id" }, standardMethods);
}]);