import { useState, useEffect } from "react"
import axios from "axios"
const Radio = (props) => {
    const [answers, setAnswers] = useState([])
    const [loading, setLoading] = useState(true)

    const handleRadioChange = (e) => {
        const { value } = e.target;
        props.setScore((prev) => {
          const updated = prev.filter((item) => item)
          return [...updated, Number(value)];
        });
    };
    useEffect(() => {
        const loadAnswers = async () => {
            try {
                const res = await axios.get(`http://localhost:5017/answers/${props.id}`)
                setAnswers(res.data)
            } catch (err) {
                console.error(err)
            }
        }
        if(loading){
            setLoading(false)
            loadAnswers()
        }
    }, [loading, props])
    
    return(
        <fieldset>
            <legend>{props.name}</legend>
            {answers.map((answer) => (
                <div key={answer.id}>
                    <input required type="radio" id = {props.id} name = {props.id} value = {answer.id} onChange={handleRadioChange}/>
                    <label htmlFor = {props.id}>{answer.name}</label>
                </div>
            ))}
        </fieldset>
    )
}

export default Radio