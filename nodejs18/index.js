const uuid = require("uuid");
module.exports = function (req, res) {
  res.send({
    result: uuid.v4(),
  });
};
