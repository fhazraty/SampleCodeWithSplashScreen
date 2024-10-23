namespace SampleCodeWithSplashScreen
{
	public class Student
	{
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string StudentNo { get; set; }
        public Gender Gender { get; set; }
        public string Major { get; set; }
    }
    public enum Gender
    {
		زن = 0,
		مرد = 1,
        سایر = 2
    }
}
