import './App.css'
import axios from 'axios'
import React, { useEffect } from 'react';
import Tree from './components/tree';
function App() {
  // https://localhost:7295/api/nodes/list/1
  const [nodes, setNodes] = React.useState([]);

  useEffect(() => {
    axios.get('https://localhost:7295/api/nodes/list/1')
      .then(response => {
        setNodes(response.data?.data[0]);
        console.log(response.data?.data[0]);
      })
      .catch(error => {
        console.error(error);
      });
  }, []);

  return (
    <>
    <div className='p-4 min-h-screen flex justify-center items-center'>
      <Tree data={nodes} />
    </div>
    </>
  )
}

export default App
