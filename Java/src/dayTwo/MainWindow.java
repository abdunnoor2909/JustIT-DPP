package dayTwo;

import javax.swing.*;
import javax.swing.border.EtchedBorder;
import javax.swing.border.TitledBorder;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import java.awt.*;
import java.awt.event.*;
import java.awt.geom.Arc2D;
import java.util.*;
import java.util.List;

import static dayTwo.generatePeople.people;

/**
 * Created by student on 24-Aug-16.
 */
public class MainWindow implements ActionListener {
    //making the lables in the main window

    private JLabel lblFirstname;
    private JLabel lblLastName;
    private JLabel lblHeight;
    private JLabel lblWeight;
    private JLabel lblBirthdate;
    private JLabel lblSex;
    private JLabel lblPosition;
    private JLabel lblHireDate;

    //making the text fields.
    private JTextField txtFirstName;
    private JTextField txtLastName;
    private JTextField txtHeight;
    private JTextField txtWeight;
    private JTextField txtBirthdate;
    private JTextField txtSex;
    private JTextField txtPosition;
    private JTextField txtHireDate;

    private JButton btUpdate;
    private JButton btRemove;

    //creates the menu bar and the menus
    private  JMenuBar menuBar;
    private  JMenu fileMenu;
    private JMenu editMenu;
    private JMenuItem newMenuItem, exitMenuItem , indexMenuItem;

    //creates the contect and the panels in the window.
    private JPanel content;
    private JPanel listPanel;
    private JPanel fieldPanel;
    private JPanel inputPanel;
    private JPanel btPanel;

    private JList employeeList;
    private boolean creatNew;
    private int employeeIndex = -1;

    //CONSTRUCTOR
    public MainWindow() {
        JFrame mainFrame = new JFrame("Employee Database");
        mainFrame.setSize(800,400);
        mainFrame.setResizable(false);
        mainFrame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);
        WindowListener l = new WindowAdapter(){
            public void windowClosing(WindowEvent e) {
                int confirm = JOptionPane.showOptionDialog(mainFrame, "Are you sure? Exit", "Exit Confirmation",
                        JOptionPane.YES_NO_OPTION,
                        JOptionPane.QUESTION_MESSAGE,
                        null, null, null);
                if(confirm == 0){//IF USER CONFIRMS THEN EXIT THE PROGRAM (0)
                    mainFrame.dispose();
                    System.exit(0);
                }

            }
        };

        Dimension di = mainFrame.getToolkit().getScreenSize();//gets the size of the screen.
        mainFrame.setLocation(di.width/2 - mainFrame.getWidth()/2, di.height/2 - mainFrame.getHeight()/2);//will make it position the window in the centre.

        mainFrame.addWindowListener(l);

        mainFrame.setJMenuBar(createMenu());


        content = (JPanel) mainFrame.getContentPane();//add panel into the frame.
        content.setLayout(new GridLayout(1,2,5,5));//creates the measurement of the panel
        prepareJList();
        listPanel = new JPanel();
        listPanel.setBorder(new EtchedBorder(EtchedBorder.LOWERED));
        JScrollPane scrollPane = new JScrollPane(createEmployeeList());
        scrollPane.setPreferredSize(new Dimension(380,335));
        listPanel.add(scrollPane);//THIS IS THE LIST PANEL INSIDE THE CONTENT PANEL.
        listPanel.setVisible(false);
        content.add(listPanel);



        fieldPanel = new JPanel();
        TitledBorder title;
        title = BorderFactory.createTitledBorder("Employee's Details");
        fieldPanel.setBorder(title);
        fieldPanel.add(createFieldspanel(), BorderLayout.CENTER);//creates the text fields in the main window.
        fieldPanel.add(createButtonPanel(), BorderLayout.SOUTH);//creates buttons to the main window.
        fieldPanel.setVisible(false);

        content.add(fieldPanel);

        mainFrame.setVisible(true);

    }

    private JMenuBar createMenu(){
        menuBar = new JMenuBar();//creates a menu bar


        //Creating the 'File' menu
        fileMenu = new JMenu(("File"));
        fileMenu.setMnemonic(KeyEvent.VK_F);
        newMenuItem = new JMenuItem("New");
        newMenuItem.setMnemonic(KeyEvent.VK_N);
        newMenuItem.addActionListener(this);
        fileMenu.add(newMenuItem);

        exitMenuItem = new JMenuItem("Exit");
        exitMenuItem.setMnemonic(KeyEvent.VK_E);
        exitMenuItem.addActionListener(this);
        fileMenu.add(exitMenuItem);

        menuBar.add(fileMenu);//adds 'File' menu to the menu bar


        //edit menu

        editMenu = new JMenu(("Edit"));
        editMenu.setMnemonic(KeyEvent.VK_D);
        indexMenuItem = new JMenuItem("Search");
        indexMenuItem.setMnemonic(KeyEvent.VK_S);
        indexMenuItem.addActionListener(this);
        editMenu.add(indexMenuItem);

        menuBar.add(editMenu);//adds edit menu to the menu bar

        return menuBar;
    }

    //CREATES THE LIST
    private void prepareJList(){
        employeeList = new JList();
        employeeList.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        employeeList.addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {//once the field is selected. the listener gets executed
                employeeIndex = employeeList.getSelectedIndex();
                if(people.size()>0 && employeeIndex!= -1)
                    loadEmployeeFields(employeeIndex);
                else
                    clearTextField();
            }
        });
    }

    private JList createEmployeeList(){//DYNAMACLLY RELOADS THE LIST
        DefaultListModel listModel = new DefaultListModel();
        if (people.size()>0){
            for(Employee e : people)
                listModel.addElement(e);

        }
        employeeList.setModel(listModel);


        return employeeList;
    }
    //Creates the fields for text

    private JPanel createFieldspanel(){
        inputPanel= new JPanel();
        inputPanel.setLayout((new GridLayout(0,2,5,5)));

        lblFirstname = new JLabel("First name");
        inputPanel.add(lblFirstname);
        txtFirstName = new JTextField();
        inputPanel.add(txtFirstName);

        lblLastName = new JLabel("Last name");
        inputPanel.add(lblLastName);
        txtLastName= new JTextField();
        inputPanel.add(txtLastName);

        lblHeight = new JLabel("Height");
        inputPanel.add(lblHeight);
        txtHeight= new JTextField();
        inputPanel.add(txtHeight);

        lblWeight = new JLabel("Weight");
        inputPanel.add(lblWeight);
        txtWeight= new JTextField();
        inputPanel.add(txtWeight);

        lblBirthdate = new JLabel("Date of Birth (YYYY-MM-DD)");
        inputPanel.add(lblBirthdate);
        txtBirthdate= new JTextField();
        inputPanel.add(txtBirthdate);

        lblSex = new JLabel("Sex (M/F)");
        inputPanel.add(lblSex);
        txtSex= new JTextField();
        inputPanel.add(txtSex);

        lblPosition = new JLabel("Position:");
        inputPanel.add(lblPosition);
        txtPosition= new JTextField();
        inputPanel.add(txtPosition);

        lblHireDate = new JLabel("Date Hired: (YYYY-MM-DD)");
        inputPanel.add(lblHireDate);
        txtHireDate= new JTextField();
        inputPanel.add(txtHireDate);

        return inputPanel;
    }
    //constructors the buttons

    private JPanel createButtonPanel(){
        btPanel = new JPanel();
        btPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));

        btUpdate = new JButton("Update");
        btUpdate.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(creatNew && employeeList.isSelectionEmpty()) {
                    TaskProcessing.createEmployee(getFieldsInfo());
                    createEmployeeList();
                    creatNew = false;
                    clearTextField();
                }
                else{
                    TaskProcessing.editDetails(employeeIndex, getFieldsInfo());
                    createEmployeeList();
                    listPanel.setVisible(true);
                }
                creatNew = false;
                employeeIndex = -1;

            }
        });
        btPanel.add(btUpdate);


        btRemove = new JButton("Remove NOT BOOM");
        btRemove.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(employeeIndex >= 0) {
                    TaskProcessing.removeEmployee(employeeIndex);
                    clearTextField();
                    createEmployeeList();
                    employeeIndex = -1;
                }else
                    JOptionPane.showMessageDialog(null, "No Employee Selected");


            }
        });

        btPanel.add(btRemove);

      return btPanel;
    }


    @Override
    public void actionPerformed(ActionEvent e) {
        String action = e.getActionCommand();

        if ("New".equals(action)){
            clearTextField();
            if(employeeIndex<0)
            creatNew = true;
            listPanel.setVisible(true);
            fieldPanel.setVisible(true);
        }
        else if ("Exit".equals(action)){
            System.exit(0);
        }else if (("Search".equals(action))){
            String fnSearch = JOptionPane.showInputDialog(("Enter first name:"));
            employeeIndex = TaskProcessing.searchFirstname(fnSearch);
            if (employeeIndex!= -1)
                loadEmployeeFields(employeeIndex);
            employeeList.setVisible(true);}


            else
                JOptionPane.showMessageDialog(null, "Cannot find it");
        }



    private void clearTextField(){//CLEANS ALL THE TEXT FIELDS
        txtFirstName.setText("");
        txtLastName.setText("");
        txtHeight.setText("");
        txtWeight.setText("");
        txtBirthdate.setText("");
        txtSex.setText("");
        txtPosition.setText("");
        txtHireDate.setText("");
    }

    private void loadEmployeeFields(int index){//DISPLAYS THE LIST ACCORDING TO THE INDEX SELECTED. (INT INDEX)
        txtFirstName.setText(people.get(index).getFirstName());
        txtLastName.setText(people.get(index).getLastName());
        txtHeight.setText(Short.toString(people.get(index).getHeight()));
        txtWeight.setText(Double.toString(people.get(index).getWeight()));
        txtBirthdate.setText(people.get(index).getBirthDate().toString());
        txtSex.setText(people.get(index).getSex().toString());
        txtPosition.setText(people.get(index).getPosition());
        txtHireDate.setText(people.get(index).getHireDate().toString());
    }

    private List<String> getFieldsInfo(){
        List<String>data = new ArrayList<>();

        data.add(txtFirstName.getText());
        data.add(txtLastName.getText());
        data.add(txtHeight.getText());
        data.add(txtWeight.getText());

        String[] stringDob = txtBirthdate.getText().split("-");
        data.add(stringDob[0]);
        data.add(stringDob[1]);
        data.add(stringDob[2]);

        data.add(txtSex.getText());
        data.add(txtPosition.getText());

        String[] stringHireDate = txtHireDate.getText().split("-");
        data.add(stringDob[0]);
        data.add(stringDob[1]);
        data.add(stringDob[2]);

        return data;

    }

}
