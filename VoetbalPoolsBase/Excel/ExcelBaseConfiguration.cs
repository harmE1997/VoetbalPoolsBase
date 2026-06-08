namespace VoetbalPoolsBase.Excel;

public static class ExcelBaseConfiguration
{
    public static int StartRow;
    public static int HomeColumn;
    public static int OutColumn;
    public static int PostponementColumn = HomeColumn - 1;
    public static int RankingSheet;
    public static int TopscorersSheet;
    public static int BonusStartRow;
    public static int BonusAnswerColumn;
    public static int BonusRoundsColumn = BonusAnswerColumn + 1;
    public static int NrBonusAnswers;
    public static int FirstHalfSize = 6;
    public static int HalfWayJump = 0;
}
