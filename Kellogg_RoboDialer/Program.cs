namespace Kellogg_RoboDialer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Phone[] call = new Phone[10];
			call[0] = new HomePhone("(303) 985-5060", "CompuTest", "1");
			call[1] = new CellPhone("(603) 532-4123", "Curtis Manufacturing", "2");
			call[2] = new HomePhone("(800) 876-2524", "Data Functions", "1");
			call[3] = new HomePhone("(708) 397-3330", "Donnay Repair", "1");
			call[4] = new HomePhone("(360) 434-3894", "ErgoNomic Inc", "1");
			call[5] = new HomePhone("(800) 969-4374", "ErgoSource", "1");
			call[6] = new CellPhone("(800) 874-8527", "Fox Bay Industries", "2");
			call[7] = new CellPhone("(800) 545-6254", "Glare-Guard", "2");
			call[8] = new CellPhone("(407) 783-6641", "Hazard Comm Specialists", "2");
			call[9] = new CellPhone("(714) 472-4409", "Komfort Support", "2");

			for (int i = 0; i < call.Length; i++)
			{
				Console.WriteLine(call[i].Dial());
			}
		}
	}
}