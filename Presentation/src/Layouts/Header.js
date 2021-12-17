import {BrowserRouter,Routes,Route, Link} from "react-router-dom";


const Header = () =>{

    return(

        <header className="app-header">
            <Link className="app-header__logo" to="/">Test V8 Front</Link>
            <a className="app-sidebar__toggle" href="#" data-toggle="sidebar" aria-label="Hide Sidebar" /> 
  
            <ul className="app-nav">
                
    
                <li className="dropdown"><a className="app-nav__item" href="#" data-toggle="dropdown" aria-label="Open Profile Menu"><i className="fa fa-user fa-lg" /></a>
                    <ul className="dropdown-menu settings-menu dropdown-menu-right">
                        <li><Link className="dropdown-item" to="/"><i className="fa fa-sign-out fa-lg" /> Logout</Link></li>
                    </ul>
                </li>
            </ul>
        </header>

    )

}

export default Header;