var URLconfiguration = {
    weburl: "http://localhost:31822/",
    apiurl: "http://localhost:31930/",

    generateApiUrl: function (serviceUrl) {
        return URLconfiguration.apiurl + serviceUrl;
    }
}