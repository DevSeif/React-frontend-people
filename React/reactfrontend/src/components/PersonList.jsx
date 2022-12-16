import React from "react";
import axios from "axios";
import { DetailsButton } from "./DetailsButton";
import { useEffect, useState } from "react";

export default function PersonList() {
  const [people, setPeople] = useState([]);
  const [sort, setSort] = useState(false);

  useEffect(() => {
    fetchData();
  }, []);

  function fetchData() {
    axios.get(`https://localhost:7035/api/react`).then((result) => {
      console.log("Executed fetchData");
      setPeople(result.data);
    });
  }

  return (
    <div>
      <button
        className="btn btn-danger my-3"
        onClick={() => {
          setSort(!sort);
          fetchData();
        }}
      >
        Sort people by name
      </button>
      <table className="table my-2">
        <thead>
          <tr>
            <th>Name</th>
            <th>Information</th>
          </tr>
        </thead>
        <tbody>
          {sort
            ? people
                .sort((a, b) => a.name.localeCompare(b.name))
                .map((person) => (
                  <tr>
                    <td key={person.personId}>{person.name}</td>
                    <td>
                      <DetailsButton
                        myperson={person}
                        onButtonClick={fetchData}
                      />
                    </td>
                  </tr>
                ))
            : people.map((person) => (
                <tr>
                  <td key={person.personId}>{person.name}</td>
                  <td>
                    <DetailsButton
                      myperson={person}
                      onButtonClick={fetchData}
                    />
                  </td>
                </tr>
              ))}
        </tbody>
      </table>
    </div>
  );
}
