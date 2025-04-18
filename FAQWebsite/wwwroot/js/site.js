document.addEventListener("DOMContentLoaded", function () {
    const faqItems = document.querySelectorAll(".faq-item");
    faqItems.forEach(item => {
        item.addEventListener("click", function () {
            const answer = this.querySelector(".faq-answer");
            answer.style.display = answer.style.display === "none" ? "block" : "none";
        });
    });
});
