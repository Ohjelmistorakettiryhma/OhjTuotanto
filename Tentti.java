import java.util.Scanner;
public class Tentti {
    private double pisteet;

    public void setPisteet(double p){
        this.pisteet = p;
    }

    public double getPisteet(){
        return this.pisteet;
    }

    public int getArvosana(){
        int arvosana;

        if (this.pisteet >= 90) {
            arvosana = 5;
        }
        else if (this.pisteet >= 80) {
            arvosana = 4;
        }
        else if (this.pisteet >= 70) {
            arvosana = 3;
        }
        else if (this.pisteet >= 60) {
            arvosana = 2;
        }
        else if (this.pisteet >= 50) {
            arvosana = 1;
        }
        else {
            arvosana = 0;
        }
        return arvosana;
    }

}

// luodaan aliluokkaa Essee
class Essee extends Tentti{
    public double Pisteet(){
        Scanner input = new Scanner(System.in);
        boolean ok = false;
        // a
        System.out.println("Anna pisteet kieliopista (max. 30p): ");
        double kielioppi = input.nextDouble();
        while(!ok){
            if(kielioppi > 30 || kielioppi < 0){
                System.out.println("Tämä syöte ei kelpaa.");
                System.out.println("Annettujen pisteiden tulee olla luku 0:n ja 30:n väliltä.");
                System.out.println("Anna pisteet kieliopista (max. 30p): ");
                kielioppi = input.nextDouble();
            }
            else{
                ok = true;
                System.out.println("Pisteet kieliopista ok.");
            }
        }
        ok = false;
        // b
        System.out.println("Anna pisteet oikeinkirjoituksesta (max. 20p): ");
        double oikeinkirjoitus = input.nextDouble();
        while(!ok){
            if(oikeinkirjoitus > 20 || oikeinkirjoitus < 0){
                System.out.println("Tämä syöte ei kelpaa.");
                System.out.println("Annettujen pisteiden tulee olla luku 0:n ja 20:n väliltä.");
                System.out.println("Anna pisteet oikeinkirjoituksesta (max. 20p): ");
                oikeinkirjoitus = input.nextDouble();
            }
            else{
                ok = true;
                System.out.println("Pisteet oikeinkirjoituksesta ok.");
            }
        }
        ok = false;
        // c
        System.out.println("Anna pisteet pituudesta (max. 20p): ");
        double pituus = input.nextDouble();
        while(!ok){
            if(pituus > 20 || pituus < 0){
                System.out.println("Tämä syöte ei kelpaa.");
                System.out.println("Annettujen pisteiden tulee olla luku 0:n ja 20:n väliltä.");
                System.out.println("Anna pisteet pituudesta (max. 20p): ");
                pituus = input.nextDouble();
            }
            else{
                ok = true;
                System.out.println("Pisteet pituudesta ok.");
            }
        }
        ok = false;
        // d
        System.out.println("Anna pisteet sisällöstä (max. 30p): ");
        double sisalto = input.nextDouble();
        while(!ok){
            if(sisalto > 30 || sisalto < 0){
                System.out.println("Tämä syöte ei kelpaa.");
                System.out.println("Annettujen pisteiden tulee olla luku 0:n ja 30:n väliltä.");
                System.out.println("Anna pisteet sisällöstä (max. 30p): ");
                sisalto = input.nextDouble();
            }
            else{
                ok = true;
                System.out.println("Pisteet sisällöstä ok.");
            }
        }
        // lasketaan ja palautetaan kokonaispisteet
        return kielioppi + oikeinkirjoitus + pituus + sisalto;
        }

    public static void main(String [] args){
        Essee olio = new Essee();
        double p = olio.Pisteet();
        olio.setPisteet(p);
        int numero = olio.getArvosana();
        System.out.println("Yhteensä pisteet esseestä: " + p);
        System.out.println("Arvosana: " + numero);
    }
}