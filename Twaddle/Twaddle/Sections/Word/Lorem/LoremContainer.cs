using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bickers.Twaddle.Containers.Lorem
{
    /// <summary>
    /// The default implementation for the word list container.
    /// </summary>
    public class LoremWordContainer : WordListContainer
    {
        public override List<string> GetWordList()
        {
            return "Lorem,ipsum,dolor,sit,amet,consectetuer,adipiscing,elit,Aenean,commodo,ligula,eget,massa,Cum,sociis,natoque,penatibus,et,magnis,dis,parturient,montes,nascetur,ridiculus,mus,Donec,quam,felis,ultricies,nec,pellentesque,eu,pretium,quis,sem,Nulla,consequat,enim,pede,justo,fringilla,vel,aliquet,vulputate,arcu,In,rhoncus,ut,imperdiet,a,venenatis,vitae,Nullam,dictum,mollis,Integer,tincidunt,Cras,dapibus,Vivamus,elementum,semper,nisi,eleifend,tellus,leo,porttitor,ac,Aliquam,ante,viverra,feugiat,Phasellus,metus,varius,laoreet,Quisque,rutrum,Etiam,augue,Curabitur,ullamcorper,Nam,dui,Maecenas,tempus,condimentum,libero,neque,sed,nunc,blandit,luctus,pulvinar,hendrerit,id,odio,sapien,faucibus,orci,eros,Duis,mauris,nibh,sodales,sagittis,magna,bibendum,velit,cursus,gravida,mi,Fusce,Vestibulum,purus,scelerisque,nonummy,accumsan,turpis,primis,ultrices,posuere,cubilia,Curae;,lacinia,tortor,suscipit,iaculis,Praesent,volutpat,nisl,lectus,risus,facilisis,non,auctor,euismod,malesuada,congue,erat,at,placerat,mattis,sollicitudin,urna,lacus,Suspendisse,diam,habitant,morbi,tristique,senectus,netus,fames,egestas,tempor,Proin,porta,est,hac,habitasse,platea,dictumst,ornare,lobortis,vehicula,interdum,fermentum,convallis,molestie,pharetra".Split(',').ToList();
        }
    }



    /// <summary>
    /// Gets the list of words by reading each line of a text file
    /// </summary>
    public class FileSystemWordContainer : WordListContainer
    {

        string _targetFileLocation = null;

        /// <summary>
        /// The location of the text file that will be read. Each word must start on its own line for the word to show up seperately 
        /// </summary>
        /// <param name="targetFileLocation"></param>
        public FileSystemWordContainer(string targetFileLocation)
        {
            if (string.IsNullOrWhiteSpace(targetFileLocation))
            {
                throw new System.ArgumentException("The provided target file location is null or empty. Target file location must be provided", nameof(targetFileLocation));
            }

            _targetFileLocation = targetFileLocation;
        }


        /// <summary>
        /// Gets the word list that has been found from the target file location
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public override List<string> GetWordList()
        {

            if (!File.Exists(_targetFileLocation))
            {
                throw new FileNotFoundException();
            }

            var actualPath = Path.Combine(_targetFileLocation);
            var lines = File.ReadAllLines(actualPath);

            return lines.ToList();
        }
    }



}