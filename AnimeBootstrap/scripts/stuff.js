var x, y, prev, obj = [];

$(document).ready(function () {
    for (var i = 1; i <= 20; i++) {

        if (i > 10) {
            $("div.col-md-9").append('<img src="images/' + i + '.jpg" id="' + i + '" class="img-thumbnail col-lg-1 col-md-2 col-sm-3 col-xs-4 OVAs" />');
            obj.push({ id: i, title: "title" + i, desc: "desc" + i });
        }
        else {
            $("div.col-md-9").append('<img src="images/' + i + '.jpg" id="' + i + '" class="img-thumbnail col-lg-1 col-md-2 col-sm-3 col-xs-4" />');
            obj.push({ id: i, title: "title" + i, desc: "desc" + i });
        }

    }


    $("img").css("height", $("img").last().css("width"));
    $("#refresh").click(function (event) {
        event.preventDefault();
        $("img").not(".col-lg-12").css("height", $("img").last().css("width"));
    });
    $(window).resize(function () {
        $("img").not(".col-lg-12").css("height", $("img").last().css("width"));

    });

    $("img").bind("click", function () {
        if (x != undefined)
            x.insertAfter(prev);
        x = $(this);
        prev = x.prev();
        y = $("img").filter(".col-lg-12").get(0);

        if (!(x.hasClass("col-lg-12")))
            x.insertBefore(x.parent().children().first());

        if (x.get(0) != y) {
            $(y).toggleClass("col-lg-12 col-md-12 col-sm-12 col-xs-12").toggleClass("col-lg-1 col-md-2 col-sm-3 col-xs-4");
            if (y != undefined)
                y.style.height = $(y).next().css("width");
            var i = parseInt(x.attr("id"));
            $("#title").text(obj[i - 1].title);
            $("#description").text(obj[i - 1].desc);
        }
        else {
            $("#title").text("Anime");
            $("#description").text("");
        }
        x.toggleClass("col-lg-1 col-md-2 col-sm-3 col-xs-4");
        x.toggleClass("col-lg-12 col-md-12 col-sm-12 col-xs-12");
        if (x.hasClass("col-lg-12")) {
            x[0].style.height = "auto";
        }
        else {
            if (x.prev().length)
                x[0].style.height = x.prev().css("width");
            else
                x[0].style.height = x.next().css("width");
        }

    });
})

function menu() {
    $(".in").collapse("hide");
    setTimeout(function(){
        if ($(".collapsing").length == 1)
            $(".annoying").collapse("show");
    },50)
}

function showOVAs() {
    $("img").filter(".OVAs").show();
    $("img").not(".OVAs").hide();
}
function showAll() {
    $("img").show();
}
