define(["jquery"], function ($) {
    return $.fn.comboBox = function () {
        var $self = $(this);
        var $persons = $self.find(".person-item");
        var $selectedPerson = $self.find(".selectedPerson");

        $persons.hide();
        $selectedPerson.on("click", function () {
            $persons.show();
        });

        $persons.on("click", function () {
            var $this = $(this);
            $selectedPerson.html($this.html());
            $persons.hide();
        })

        return $self;
    }
});