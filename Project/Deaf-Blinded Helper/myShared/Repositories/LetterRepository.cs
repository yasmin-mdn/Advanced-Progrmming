using System.Collections.Generic;
using myShared.Models;
using System.Linq;
using myShared.Repositories;
//using Microsoft.AspNetCore.Mvc;

namespace myShared.Repositories{
    public class LetterRepository{
        public static IEnumerable<Letter> letters=new List<Letter>(){
            new Letter{
                Id=1,
                Symbol='a',
                PicPath="A.jpg",
                fingerorders=SensorRepository.Sensor.sensor_p1
            },
             new Letter{
                Id=2,
                Symbol='b',
                PicPath="B.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm2
            },
             new Letter{
                Id=3,
                Symbol='c',
                PicPath="C.jpg",
                fingerorders=SensorRepository.Sensor.sensor_p1|SensorRepository.Sensor.sensor_p3|SensorRepository.Sensor.sensor_i3|SensorRepository.Sensor.sensor_i2|SensorRepository.Sensor.sensor_i5
            },
             new Letter{
                Id=4,
                Symbol='d',
                PicPath="D.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i1|SensorRepository.Sensor.sensor_i6
            },
             new Letter{
                Id=5,
                Symbol='e',
                PicPath="E.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i1
            },
             new Letter{
                Id=6,
                Symbol='f',
                PicPath="F.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i2|SensorRepository.Sensor.sensor_i3
            },
             new Letter{
                Id=7,
                Symbol='g',
                PicPath="G.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm1|SensorRepository.Sensor.sensor_palm2
            },
             new Letter{
                Id=8,
                Symbol='h',
                PicPath="H.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm0
            },new Letter{
                Id=9,
                Symbol='i',
                PicPath="I.jpg",
                fingerorders=SensorRepository.Sensor.sensor_m1
            },new Letter{
                Id=10,
                Symbol='j',
                PicPath="J.jpg",
                fingerorders=SensorRepository.Sensor.sensor_m1|SensorRepository.Sensor.sensor_palm6|SensorRepository.Sensor.sensor_palm4|SensorRepository.Sensor.sensor_palm1|SensorRepository.Sensor.sensor_p1
            },new Letter{
                Id=11,
                Symbol='k',
                PicPath="K.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i4|SensorRepository.Sensor.sensor_i6
            },new Letter{
                Id=12,
                Symbol='l',
                PicPath="L.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm1|SensorRepository.Sensor.sensor_palm2|SensorRepository.Sensor.sensor_palm3
            },new Letter{
                Id=13,
                Symbol='m',
                PicPath="M.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm1|SensorRepository.Sensor.sensor_palm2|SensorRepository.Sensor.sensor_palm3
                            |SensorRepository.Sensor.sensor_palm4|SensorRepository.Sensor.sensor_palm5|SensorRepository.Sensor.sensor_palm6|SensorRepository.Sensor.sensor_palm7
            },new Letter{
                Id=14,
                Symbol='n',
                PicPath="N.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm1|SensorRepository.Sensor.sensor_palm2|SensorRepository.Sensor.sensor_palm3
                            |SensorRepository.Sensor.sensor_palm4|SensorRepository.Sensor.sensor_palm5
            },new Letter{
                Id=15,
                Symbol='o',
                PicPath="O.jpg",
                fingerorders=SensorRepository.Sensor.sensor_a1
            },new Letter{
                Id=16,
                Symbol='p',
                PicPath="P.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i1
            },new Letter{
                Id=17,
                Symbol='q',
                PicPath="Q.jpg",
                fingerorders=SensorRepository.Sensor.sensor_p2
            },new Letter{
                Id=18,
                Symbol='r',
                PicPath="R.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm3|SensorRepository.Sensor.sensor_palm5|SensorRepository.Sensor.sensor_palm7
            },
            new Letter{
                Id=19,
                Symbol='s',
                PicPath="S.jpg",
                fingerorders=SensorRepository.Sensor.sensor_x2
            },
            new Letter{
                Id=20,
                Symbol='t',
                PicPath="T.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm3
            },new Letter{
                Id=21,
                Symbol='u',
                PicPath="U.jpg",
                fingerorders=SensorRepository.Sensor.sensor_x1
            },new Letter{
                Id=22,
                Symbol='v',
                PicPath="V.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm1|SensorRepository.Sensor.sensor_palm5|SensorRepository.Sensor.sensor_palm6
            },new Letter{
                Id=23,
                Symbol='w',
                PicPath="W.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i5|SensorRepository.Sensor.sensor_i2|SensorRepository.Sensor.sensor_i3
            },new Letter{
                Id=24,
                Symbol='x',
                PicPath="X.jpg",
                fingerorders=SensorRepository.Sensor.sensor_i3
            },new Letter{
                Id=25,
                Symbol='y',
                PicPath="Y.jpg",
                fingerorders=SensorRepository.Sensor.sensor_p3|SensorRepository.Sensor.sensor_palm0
            },new Letter{
                Id=26,
                Symbol='z',
                PicPath="Z.jpg",
                fingerorders=SensorRepository.Sensor.sensor_palm4|SensorRepository.Sensor.sensor_palm3|SensorRepository.Sensor.sensor_palm2|SensorRepository.Sensor.sensor_palm1
            }

        };

        public Letter GetletterbySymbol(char c)=> letters.FirstOrDefault((l)=>l.Symbol==c);
       

        public void AddOwnfingerPositions(Letter letter){
            letters.FirstOrDefault(l=>l.Symbol==letter.Symbol)
            .fingerorders=letter.fingerorders;
        }
    }
}