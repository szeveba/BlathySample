class Book {
    /**
     * @param {string} title 
     * @param {string} author 
     * @param {string} genre 
     * @param {Date} published 
     */
    constructor(title = "", author = "", genre = "", published = Date.now()) {
        /**@type {string} */
        this.title = title;
        /**@type {string} */
        this.author = author;
        /**@type {Date} */
        this.published = published;
        /**@type {string} */
        this.genre = genre;
    }
}

class ListItem {
    constructor(){
        this.element = document.createElement("li");
        this.element.classList.add("list-group-item")
    }
}

class List {
    constructor(){
        this.element = document.createElement("ul");
        this.element.classList.add("list-group");
    }
}

class BookList extends List {
    constructor(){
    }
}
class BookListItem extends ListItem {
    /**@param {Book} book */
    constructor(book){
        this.element.textContent = book.title;
    }
}