import { useEffect, useState } from "react"
import axios from "axios"
const Freeform = (props) => {
    const [answer, setAnswer] = useState("")
    const [loading, setLoading] = useState(true)
    const isCorrect = (e) => {
        if(e.target.value.toLowerCase() === answer.name){
            return answer.id
        } else {
            return -1
        }
    }

    const handleFreeformChange = (e) => {
        props.setScore((prev) => {
          const updated = prev.filter((item) => item !== isCorrect(e));
          return [...updated, isCorrect(e)]
        });
      };

    useEffect(() => {
        const loadAnswers = async () => {
            try {
                const res = await axios.get(`http://localhost:5017/answers/${props.id}`)
                setAnswer(res.data[0])
            } catch (err) {
                console.error(err)
            }
        }
        if(loading){
            setLoading(false)
            loadAnswers()
        }
    }, [props.id, loading])
    return(
        <fieldset>
            <legend>{props.name}</legend>
            <div>
                <textarea required name = {props.id} id = {props.id} onChange={handleFreeformChange}></textarea>
            </div>
        </fieldset>
    )
}

export default Freeform