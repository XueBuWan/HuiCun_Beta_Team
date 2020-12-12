
function move() {
    var src = $("#opt").attr("src");
    if (src == "../Pictures/left.jpg") {
        $("#side").animate({ left: '-110px' });
        $("#opt").attr("src", "../Pictures/right.jpg")
    } else {
        $("#side").animate({ left: '0px' });
        console.log("right");
        $("#opt").attr("src", "../Pictures/left.jpg")
    }
    
   
}
