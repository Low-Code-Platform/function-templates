const uuid = require("uuid");
module.exports = function (context) {
  context.res.send({
    result: uuid.v4(),
  });
};
