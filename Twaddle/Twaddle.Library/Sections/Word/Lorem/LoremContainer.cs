using System.Collections.Generic;
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



}