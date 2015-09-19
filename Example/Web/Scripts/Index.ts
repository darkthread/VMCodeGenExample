$("#btnTest").click(() => {
    $.post("/home/getsampledata", (players: models.Player[]) => {
        var res =
            $.map(players, (player) =>
                player.Id + "." + player.Name + "=" + player.HighScore
                ).join("\n");
        alert(res);
    });
});
