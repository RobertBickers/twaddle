using System.Collections.Generic;
using System.Linq;

namespace Codetreehouse.Twaddle.Containers.Lorem
{
	public class FirstNameWordContainer : WordListContainer
	{
		public override List<string> GetWordList()
		{
			//Data from National Records of Scotland https://www.nrscotland.gov.uk/statistics-and-data/statistics/
			string boysNames = "Lewis, Jack,,Ryan,James,Callum,Cameron,Daniel,Liam,Jamie,Kyle,Matthew,Logan,Finlay,Adam,Alexander,Dylan,Aiden,Andrew,Ben,Aaron,Connor,Thomas,Joshua,David,Ross,Luke,Nathan,Charlie,Ethan,Aidan,Michael,John,Calum,Scott,Josh,Samuel,Kieran,Fraser,William,Oliver,Rhys,Sean,Harry,Owen,Sam,Christopher,Euan,Robert,Kai,Jay,Jake,Lucas,Jayden,Tyler,Rory,Reece,Robbie,Joseph,Max,Benjamin,Ewan,Archie,Evan,Leo,Taylor,Alfie,Blair,Arran,Leon,Angus,Craig,Murray,Declan,Zak,Brandon,Harris,Finn,Lee,Lennon,Cole,George,Jacob,Mark,Hayden,Kenzie,Alex,Shaun,Louis,Caleb,Mason,Gregor,Mohammed,Luca,Harrison,Kian,Noah,Paul,Riley,Stuart,Joe,Jonathan,Stephen";
			string girlsNames = "Sophie,Emma,Lucy,Katie,Erin,Ellie,Amy,Emily,Chloe,Olivia,Hannah,Jessica,Grace,Ava,Rebecca,Isla,Brooke,Megan,Niamh,Eilidh,Eva,Abbie,Skye,Aimee,Mia,Ruby,Anna,Sarah,Rachel,Caitlin,Lauren,Freya,Keira,Lily,Leah,Holly,Millie,Charlotte,Abigail,Molly,Kayla,Zoe,Eve,Iona,Cara,Ella,Evie,Nicole,Morgan,Jenna,Madison,Kayleigh,Summer,Paige,Daisy,Taylor,Amelia,Zara,Beth,Amber,Robyn,Georgia,Shannon,Sophia,Courtney,Jennifer,Abby,Neve,Carly,Casey,Elizabeth,Kaitlyn,Poppy,Melissa,Jasmine,Bethany,Abi,Gemma,Laura,Mya,Kara,Orla,Elise,Hayley,Kelsey,Charley,Imogen,Kirsty,Rachael,Heather,Chelsea,Layla,Samantha,Julia,Maya,Natalie,Alice,Libby,Rhianna,Rosie";
			var allNames = boysNames + "," + girlsNames;

			return allNames.Split(',').ToList();
		}
	}
}