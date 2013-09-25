var employeeNS = employeeNS || {};

//$(document).ready(function () {
    employeeNS.employeeViewModel = {
        clientToken: ko.observable('123'),
        id: ko.observable(1),
        titleId: ko.observable(2),
        loginId: ko.observable(3),
        isLocal: ko.observable(true),
        employeeTypeId: ko.observable(4),
        current: ko.observable(true),
        personId: ko.observable(5),
        rosterId: ko.observable('7F'),
        employeeType: ko.observable(),
        person: ko.observable({
            FirstName: ko.observable('Chris'),
            LastName: ko.observable('Nattress'),
            DateOfBirth: ko.observable('1981-03-19')
        }),
        employeeTitle: ko.observable()
    }

    ko.applyBindings(employeeNS.employeeViewModel);
//});