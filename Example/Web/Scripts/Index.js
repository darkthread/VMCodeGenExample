$("#btnTest").click(function () {
    $.post("/home/getsampledata", function (players) {
        var res = $.map(players, function (player) {
            return player.Id + "." + player.Name + "=" + player.HighScore;
        }).join("\n");
        alert(res);
    });
});
//# sourceMappingURL=Index.js.map