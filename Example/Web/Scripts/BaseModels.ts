module models {
	/** The player data */
    export class Player {
        /** Identity */
        Id : string;
        /** Player name */
        Name : string;
        /** Date of registration */
        RegDate : Date;
        /** Highest score */
        HighScore : number;
        /** Rate of player */
        Rate : number;
        /** Is VIP? */
        IsVIP : boolean;
    }
	/** Game data */
    export class Game {
        /** Sequencial number */
        Seq : number;
        /** Game id */
        GameId : string;
        /** Player id */
        PlayerId : string;
        /** Date of game */
        DateTime : Date;
        /** Score */
        Score : number;
    }
}
