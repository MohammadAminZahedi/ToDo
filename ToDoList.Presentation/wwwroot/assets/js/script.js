const taskItems = document.querySelectorAll('li.task-item')


taskItems.forEach(item => {
    item.addEventListener("click", function () {
        item.classList.toggle("done");
    })
})