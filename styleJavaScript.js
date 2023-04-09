const carrousel = document.querySelector(".carrousel-items");
let interval = null;
let maxScrollLeft = carrousel.scrollWidth - carrousel.clientWidth;
let step = 1;
const start = () => {
    interval = setInterval(function () {
        carrousel.scrollLeft = carrousel.scrollLeft + step;
        if (carrousel.scrollLeft === maxScrollLeft) {
            step = step* -1;
        } else if (carrousel.scrollLeft === 0) {
            step = step* -1;
        }
    }, 10);
};

const stop = () => { };
start();