using System;
namespace practiceapp
{
    public class InfoModel
    {

		public InfoModel()
		{
			//_name = "test";
			Name = "test";
            Gender = Gender.Boy;
            Bonus = 0;
			
		}

        public Gender Gender { get; set; }
		public string Name { get; set; }
        public int Bonus { get; set; }
    }
    public enum Gender  {  Girl=0,Boy=1};
	

}
