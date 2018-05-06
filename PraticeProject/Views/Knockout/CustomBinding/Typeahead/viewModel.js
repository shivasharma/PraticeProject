var vm = (function () {
    var Person = function (first, last) {
        this.firstName = ko.observable(first);
        this.lastName = ko.observable(last);
        this.movie = ko.observable();
    }

    var p1 = new Person("abc", "Def");
    var p2 = new Person("sharma", "shiva");
    var p3 = new Person("john", "smith");

    var people = ko.observableArray([p1, p2, p3]);
    var data = ['Iron Man', 'Avenger', 'LOTR: The Two Towers', 'LOTR: The Return of the Ring', 'Thor', 'Captain America'];
    var movies = ko.observableArray(data);
    var vm = {
        movies: movies,
        moviesJSON: ko.toJSON(movies, null, 0),
        people: people
    }
    return vm;
})();
ko.applyBindings(vm);