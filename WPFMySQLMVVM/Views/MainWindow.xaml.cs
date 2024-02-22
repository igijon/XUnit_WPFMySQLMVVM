using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using WPFMySQLMVVM.Models;
using WPFMySQLMVVM.ViewModel;

namespace WPFMySQLMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Invocamos el modelo y lo asignamos a DataContext
        private UserModelView modelView = new UserModelView();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = modelView;
            //Cargamos los datos existentes en la BDD
            modelView.LoadUsers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (modelView.users == null) modelView.users = new ObservableCollection<User>();
            //Si el registro no existe, procedemos a crearlo
            if(modelView.users.Where(x => x.userName == modelView.userName).FirstOrDefault() == null)
            {
                modelView.users.Add(new User
                {
                    userName = modelView.userName,
                    mail = modelView.mail,
                    age = modelView.age
                });
                //una vez agregado el registro al modelo, lo agregamos a la BDD
                modelView.NewUser();
            }
            //Si el registro ya existe, debemos actualizarlo
            else
            {
                foreach(User r in modelView.users)
                {
                    if(r.userName.Equals(modelView.users))
                    {
                        r.mail = modelView.mail;    
                        r.age = modelView.age;
                        break;
                    }
                }

                //Actualizamos
                modelView.UpdateUser();
            }
        }
    }

   

}
