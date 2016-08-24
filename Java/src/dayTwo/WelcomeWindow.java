package dayTwo;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by student on 24-Aug-16.
 */
public class WelcomeWindow extends JFrame {//every field, method made available to welcomeWindow (extends).
    private JPanel contentPane;
    private JButton btEnter;
    private JLabel lblWelcome;

    public WelcomeWindow() {
        setTitle("Welcome Frame");//method made available form JFrame.
        setSize(800 , 400);//width and height in pixels
        setResizable(false);//means it will never be resized.

        //centre the frame
        Dimension di = getToolkit().getScreenSize();//gets the size of the screen.
        setLocation(di.width/2 - getWidth()/2, di.height/2 - getHeight()/2);//will make it position the window in the centre.

        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);//terminates the program. By default the fram will not cloase unless told to do.

        //making/ designing the container. Welcome frame.
        contentPane = new JPanel();
        contentPane.setBorder(new EmptyBorder(5,5,5,5));
        setContentPane(contentPane);
        contentPane.setLayout(null);

        btEnter = new JButton("Enter");//create a new button that says "Enter"
        btEnter.addActionListener(new ActionListener() {//when enter button is clicked event occurs.
            @Override
            public void actionPerformed(ActionEvent e) {
                MainWindow mainFrame = new MainWindow();//when button is clicked it will open the MainWindow.
            }
        });

        //set the location of the button
        btEnter.setBounds(360,200,70,25);

        contentPane.add(btEnter);//addt the button to the window frame

        //Designing the label (lblWelcome).
        lblWelcome = new JLabel("Welcome to Employee Programme");
        lblWelcome.setForeground(Color.BLUE);
        lblWelcome.setFont(new Font("Verdana", Font.BOLD | Font.ITALIC, 20));
        lblWelcome.setBounds(190,80,400,100);
        contentPane.add(lblWelcome);

        setVisible(true);//by default the windows frame nothing shows up unless told to do so



    }


}
