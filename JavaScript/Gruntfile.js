module.exports = function(grunt) {
  var SRC_DIR = 'src/';
  var TEST_DIR = 'spec/';

  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    jshint: {
      all: [
        'Gruntfile.js',
        SRC_DIR + '**/*.js',
        TEST_DIR + '**/*.js'
      ]
    }
  });

  grunt.loadNpmTasks('grunt-contrib-jshint');
  
  grunt.registerTask('default', ['jshint']);
};