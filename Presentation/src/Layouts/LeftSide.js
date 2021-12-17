import {BrowserRouter,Routes,Route, Link} from "react-router-dom";
import profilepicture from '../images/profile.jpg'
const LeftSide = () =>{

    return(

       <div>
            <div className="app-sidebar__overlay" data-toggle="sidebar" />

                <aside className="app-sidebar">
                    <div className="app-sidebar__user"><img className="app-sidebar__user-avatar" src={profilepicture} height="50" width="60" alt="User Image" />
                        <div>
                            <p className="app-sidebar__user-name">Ricardo Martinez</p>
                            <p className="app-sidebar__user-designation">Software Developer</p>
                        </div>
                    </div>
                    <ul className="app-menu">                        
                        <li className="treeview is-expanded"><a className="app-menu__item" href="#" data-toggle="treeview"><i className="app-menu__icon fa fa-file-text" /><span className="app-menu__label">Tasks</span><i className="treeview-indicator fa fa-angle-right" /></a>
                            <ul className="treeview-menu">                                
                                <Link className="treeview-item" to="/Home"><i className="icon fa fa-circle-o" /><span className="app-menu__label">Task 2</span></Link>
                                <Link className="treeview-item" to="/Task3"><i className="icon fa fa-circle-o" /><span className="app-menu__label">Task 3 y 4</span></Link>                                
                                <Link className="treeview-item" to="/Task5"><i className="icon fa fa-circle-o" /><span className="app-menu__label">Task 5</span></Link>                                
                            </ul>
                        </li>
                    </ul>
                </aside>
        </div>
)

}

export default LeftSide;