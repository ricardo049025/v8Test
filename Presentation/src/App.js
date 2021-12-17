import Home from './pages/Home.js';
import Task3 from './pages/Task3.js';
import Task5 from './pages/Task5.js';
import Layout from './Layouts/Layout.js';
import {BrowserRouter,Routes,Route} from "react-router-dom";
function App() {

  return (
    <BrowserRouter>
    <Layout/>
    <Routes>
      <Route path="/" element={<Home />}/>
      <Route path="/Home" element={<Home />} />      
      <Route path="/Task3" element={<Task3 />} />      
      <Route path="/Task5" element={<Task5 />} />      
    </Routes>
  </BrowserRouter>

  );
}

export default App;
