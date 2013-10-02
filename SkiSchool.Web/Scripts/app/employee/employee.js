function EmployeeViewModel() {

    var self = this;
    self.clientToken = ko.observable();
    self.current = ko.observable();
    self.id = ko.observable();
    self.isLocal = ko.observable();
    self.loginId = ko.observable();
    self.rosterId = ko.observable();
    self.personId = ko.observable();
    self.firstName = ko.observable();
    self.lastName = ko.observable();
    self.middleName = ko.observable();
    self.dateOfBirth = ko.observable();
    self.genderId = ko.observable();
    self.employeeTitleDesc = ko.observable();
    self.employeeTitleName = ko.observable();
    self.employeeTitleId = ko.observable();
    self.employeeTypeDesc = ko.observable();
    self.employeeTypeName = ko.observable();
    self.employeeTypeId = ko.observable();

    var employeeId = function () {
        var url = document.URL;
        var start = url.lastIndexOf("/") + 1;
        var end = url.length;
        var id = url.substring(start, end);

        return id;
    }

    $.getJSON('../../api/employees?loginId=&id=' + employeeId(), function (data) {
        self.clientToken(data.ClientToken);
        self.current(data.Current);
        self.id(data.Id);
        self.isLocal(data.IsLocal);
        self.loginId(data.LoginId);
        self.rosterId(data.RosterId);
        self.personId(data.Person.Id);
        self.firstName(data.Person.FirstName);
        self.lastName(data.Person.LastName);
        self.middleName(data.Person.MiddleName);
        self.dateOfBirth(data.Person.DateOfBirth);
        self.genderId(data.Person.GenderId);
        self.employeeTitleDesc(data.EmployeeTitle.Description);
        self.employeeTitleName(data.EmployeeTitle.Name);
        self.employeeTitleId(data.EmployeeTitle.Id);
        self.employeeTypeDesc(data.EmployeeType.Description);
        self.employeeTypeName(data.EmployeeType.Name);
        self.employeeTypeId(data.EmployeeType.Id);
    });
}

$(document).ready(function () {
    ko.applyBindings(new EmployeeViewModel());
});









