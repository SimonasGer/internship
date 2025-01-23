import { useState, useEffect } from "react"
import axios from "axios"
const Select = (props) => {
    const [answers, setAnswers] = useState([])
    const [loading, setLoading] = useState(true)

    const handleSelectChange = (e) => {
        const { value, checked } = e.target;
        props.setScore((prev) =>
          checked ? [...prev, Number(value)] : prev.filter((item) => item !== value)
        );
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
                    <input type="checkbox" id = {props.id} name = {props.id} value = {answer.id} onChange={handleSelectChange}/>
                    <label htmlFor = {props.id}>{answer.name}</label>
                </div>
            ))}
        </fieldset>
    )
}

export default Select