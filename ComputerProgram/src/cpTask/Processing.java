package cpTask;

import java.util.List;
import static cpTask.generateComputer.desktopParts;
import static cpTask.generateComputer.laptopParts;

/**
 * Created by student on 26-Aug-16.
 */
public class Processing {

    static void desktopBuild(List<String> data) {

        Desktop temp = new Desktop(data.get(0), data.get(1), data.get(2), data.get(3), data.get(4));

        desktopParts.add(temp);//temp is a temporary variable

        }

    static void laptopBuild(List<String> data){

        Laptop temp = new Laptop(data.get(0), data.get(1), data.get(2), data.get(3), data.get(4), data.get(5));
        laptopParts.add(temp);//temp is a temporary variable
    }

}
