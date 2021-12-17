import React, {useState, useEffect} from "react";
import {Table} from '../Components/Home/Table.js';
 

const Home = () =>{

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


    return (

        <main className="app-content">
            <div className="app-title">
                <div>
                    <h1><i className="fa fa-dashboard" /> Task #2</h1>
                    <p>Insert functionality for the salary table structure</p>
                </div>
            </div>

            <div className="row">
                <div className="col-md-12">
                    <div className="tile">
                        <div className="tile-body">
                            <Table data={data} />
                        </div>
                    </div>
                </div>
            </div>
            
        </main>

    )

}

export default Home;