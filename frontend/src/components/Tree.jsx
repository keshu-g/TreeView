import React from "react";

const Tree = ({ data }) => {
  return (
    <div className="flex flex-col items-center p-1 border rounded-sm border-green-700 gap-2 m-2">

      <h1 className="border-2 p-3 rounded-full border-red-500">
        {data?.letter}
      </h1>

      {data?.children?.length > 0 && (
        <div className="flex gap-2 justify-evenly">
          {data?.children?.map((item) => (
            <Tree key={item.id} data={item} />
          ))}
        </div>
      )}
    </div>
  );
};

export default Tree;
