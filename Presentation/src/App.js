import React, {useState, useEffect} from "react";
import { TableComponent } from "./components/table/table.component";
import 'bootstrap/dist/css/bootstrap.min.css';
    
const App = () => {

    const SERVER_API = "https://localhost:44382/";
    const [data, setData] = useState([]);

    useEffect(() => {
        const loadRecords = () => {
            fetch(`${SERVER_API}salary`,{
                method:"get",
                headers:{
                    'Content-Type': 'application/json'
                }
            }).then(result => result.json()).then(response => {
                setData(response);
            });
        }
        loadRecords();
    },[])

    return(
        <div className="mt-5 d-flex w-100 text-center justify-content-center">
            <TableComponent 
            id="id"
            data={data}
            />
        </div>
    )
}
export default App;