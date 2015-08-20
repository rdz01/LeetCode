module.exports = function(grunt) {
  var SRC_DIR = 'src/';
  var TEST_DIR = 'test/';

  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    jshint: {
      all: [
        'Gruntfile.js',
        SRC_DIR + '**/*.js',
        TEST_DIR + '**/*.js'
      ],
      options: {
        reporter: require('jshint-stylish')
      }
    },
    jasmine: {
      module: {
        src: SRC_DIR + '**/*.js',
        options: {
          specs: TEST_DIR + '**/*Spec.js',
          helpers: TEST_DIR + 'helper/*.js'
        }
      }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-jshint');

  grunt.registerTask('default', ['jshint', 'jasmine']);
};