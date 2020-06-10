var IntersectionObserver = IntersectionObserver || {};

IntersectionObserver.initIntersectionObserver = function () {
    const elements = document.querySelectorAll('.animate-me');

    observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.intersectionRatio > 0) {
                entry.target.classList.add("entered");
                observer.unobserve(entry.target);
            }
        });
    });

    elements.forEach(element => {
        observer.observe(element);
    });
};

IntersectionObserver.initIntersectionObserverTopButton = function (element) {
    const button = document.getElementById("go-top");

    observer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.intersectionRatio > 0) {
                button.classList.remove("displayed");
            }
            else {
                button.classList.add("displayed");
            }
        });
    });

    observer.observe(element);
};