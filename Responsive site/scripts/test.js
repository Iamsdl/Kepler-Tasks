function click1() {
    document.getElementById("div1").style.backgroundColor = "white";
    document.getElementById("div2").style.backgroundColor = "white";
    document.getElementById("div3").style.backgroundColor = "white";
    document.getElementById("div4").style.backgroundColor = "white";
    document.getElementById("div5").style.backgroundColor = "white";
    document.getElementById("li1").innerHTML = "";
    document.getElementById("li2").innerHTML = "now click me";
    document.getElementById("li2").setAttribute("onclick", "click2()");
}
function click2() {
    document.getElementById("li2").style.backgroundColor = "white";
    document.getElementById("li3").style.backgroundColor = "white";
    document.getElementById("li4").style.backgroundColor = "white";
    document.getElementById("li2").innerHTML = "";
    document.getElementById("li3").innerHTML = "now me";
    document.getElementById("li3").setAttribute("onclick", "click3()");
}
function click3() {
    document.getElementById("body").setAttribute("hidden", "true");
}
function click4() {
    alert("there is no such thing");
}