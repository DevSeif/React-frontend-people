import './App.css';
import PersonList from './components/PersonList';
import CreatePerson from './components/CreatePerson';

function App() {
  return (
    <div className="App">
      <PersonList/>
      <CreatePerson/>
    </div>
  );
}

export default App;
