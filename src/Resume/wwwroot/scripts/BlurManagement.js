document.addEventListener('click', function (e) {
    console.log(document.activeElement.toString());
    if (document.activeElement.toString() == '[object HTMLButtonElement]' || document.activeElement.toString() == '[object HTMLInputElement]') {
        document.activeElement.blur();
    }
});