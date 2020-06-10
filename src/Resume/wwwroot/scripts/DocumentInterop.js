var DocumentInterop = DocumentInterop || {};

DocumentInterop.setDocumentTitle = function (title) {
    document.title = title;
};

DocumentInterop.scrollTop = function () {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
};