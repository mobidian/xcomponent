var jasmineReporters = require("jasmine-reporters");
jasmine.VERBOSE = true;
jasmine.getEnv().addReporter(
    new jasmineReporters.JUnitXmlReporter({
        consolidateAll: false,
        savePath: "./test_output",
        filePrefix: "junit_"
    })
);