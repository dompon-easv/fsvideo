
import "./index.css";

import {useEffect, useState} from "react";
import {Api, type Book} from "../Api.ts";

const MyApi = new Api();

export function App() {

    const [books, setBooks] = useState<Book[]>([])
    
    useEffect(() => {
        MyApi.getBooks.libraryGetBooks().then(r =>
        {
            const data =r.data;
            setBooks(data)
        })
    }, []);
  return (
    <div className="app">
        {
            books.map(b =>{
               return <div key={b.bookId}>{b.bookTitle}</div> 
            })
        }
    
    </div>
  );
}

export default App;
