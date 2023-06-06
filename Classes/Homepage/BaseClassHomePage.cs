namespace LightsOut.Classes.Homepage
{
    internal class BaseClassHomePage
    {
        readonly public string AboutPageText;
        readonly internal int speedOfAnimation;
        public BaseClassHomePage()
        {
            AboutPageText = "" +
                "Project started on April 17, 2023, " +
                "\nthe project contains experimental concepts" +
                "\nsuch as being able to project a " +
                "\nfirst person perspective (illusion using " +
                "\ncolor gradients to act as depth), " +
                "\nmultiple classes, passing data between forms, " +
                "\ndisplay using 2k+ panels (yes panels," +
                "\nto simulate pixels on the screen)." +
                "\n\n\nF'r if 't be true ev'r mine own game " +
                "\ncrashes during runneth timeth, then mine " +
                "\nown grade shall beest base";
        }
        public BaseClassHomePage(int speedOfAnimation)
        {
            this.speedOfAnimation = speedOfAnimation;
            AboutPageText = "" +
                "Project started on April 17, 2023, " +
                "\nthe project contains experimental concepts" +
                "\nsuch as being able to project a " +
                "\nfirst person perspective (illusion using " +
                "\ncolor gradients to act as depth), " +
                "\nmultiple classes, passing data between forms, " +
                "\ndisplay using 2k+ panels (yes panels," +
                "\nto simulate pixels on the screen)." +
                "\n\n\nF'r if 't be true ev'r mine own game " +
                "\ncrashes during runneth timeth, then mine " +
                "\nown grade shall beest base";
        }
        public string AboutPageTextDisplay() => AboutPageText;
    }
}
