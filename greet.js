var state = {};
state.greeting;

var greet = function (name) {
  if (!name) {
    state.greeting = 'Hello, my friend';
    return;
  } else {
    clearState();
    howMany(name);
  }
}

var clearState = function () {
  state.greeting = null;
  state.lower = null;
  state.upper = null;
}

var howMany = function (name) {
  if (typeof name !== 'object') {
    name = [name];
  }
  return handleJoins(name);
}

var handleJoins = function (name) {
  for (i=0; i<name.length; i++) {
    var re = /(["'])((?:\\\1|(?!\1).)+)\1/;
    if (name[i].indexOf(',') !== -1 && !name[i].match(re)) {
      var arr = name[i].split(',');
      arr.forEach(function(el) {
        el = el.trim();
        name.splice(i,0,el);
        i++;
      })
      name.splice(i,1);
    } else if (name[i].match(re)) {
      name[i] = name[i].slice(1, name[i].length-1);
    }
  }
  return checkCase(name);
}

var checkCase = function (name) {
  var upper = [], lower = [];
  for (i = 0; i < name.length; i++) {
    if (name[i].toUpperCase() === name[i]) {
      upper.push(name[i]);
    } else {
      lower.push(name[i]);
    }
  }
  state.upper = upper;
  state.lower = lower;
  buildString();
}

var buildString = function () {
  if(state.lower.length) {
    state.greeting = 'Hello, ';
    if(state.lower.length === 1) {
      state.greeting += state.lower[0];
    } else if (state.lower.length === 2) {
      state.greeting += state.lower[0] + ' and ' + state.lower[1];
    } else if (state.lower.length > 2) {
      for(j=0; j<state.lower.length-1; j++) {
        state.greeting += state.lower[j] + ', ';
      }
      state.greeting += 'and ' + state.lower[state.lower.length-1];
    }
  }
  if(state.upper.length) {
    buildShoutyString();
  }
}

var buildShoutyString = function () {
  if (state.greeting) {
    state.greeting += '. AND HELLO, ';
  } else {
    state.greeting = 'HELLO, ';
  }
  if(state.upper.length === 1) {
    state.greeting += state.upper[0] + '!';
  } else if (state.upper.length === 2) {
    state.greeting += state.upper[0] + ' AND ' + state.upper[1] + '!';
  } else if (state.upper.length > 2) {
    for(k = 0; k < state.upper.length-1; k++) {
      state.greeting += state.upper[k] + ', ';
    }
    state.greeting += 'AND ' + state.upper[state.upper.length-1] + '!';
  }
}
