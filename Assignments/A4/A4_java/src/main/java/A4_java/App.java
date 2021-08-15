package A4_java;

import org.checkerframework.checker.units.qual.g;

public class App {

    public enum Config 
    {
        Graphic(1),
        Ram(2),
        Cpu(4);

        public int ConfigValue;
        public int Value;

        private Config(int configValue)
        {
            this.ConfigValue = configValue;
            this.Value=this.ConfigValue;
        }
         public void ChangeValue(int v){
            this.Value=v;
        }
    }

    public static String ChooseBest(Config c){
        String st=null;
        boolean graphic=(((Config.Graphic.ConfigValue|c.Value)==c.Value));
        boolean ram=(((Config.Ram.ConfigValue|c.Value)==c.Value));
        boolean cpu=(((Config.Cpu.ConfigValue|c.Value)==c.Value));
        
        if(graphic&&ram&&cpu)
                st="Excellent";
            else if((graphic&&ram)||(ram&&cpu))
                st="Very Good";
            else if(ram)
                st="Good";
            else if(cpu||graphic)
                st="Not Bad";

    return st;
    }

    

    public static void main(String[] args) {
        
    }
}
