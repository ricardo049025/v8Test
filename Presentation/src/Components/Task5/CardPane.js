import {useState,useEffect} from "react";

export const CardPane = (props) => {

    return(
    <div className="tile">
        <h3 className="tile-title"> Bonus</h3>
        <div className="tile-body">
            <div className="text-center">
                    <h4>$ {props.bonus} USD</h4>
            </div>
        </div>
        <div className="tile-footer">            
        </div>
    </div>
    )
};