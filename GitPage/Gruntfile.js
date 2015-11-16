module.exports = function (grunt) {
    var BUILD_DIR = 'dist/';
    var SRC_DIR = 'src/';

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        clean: {
            build: {
                src: [BUILD_DIR, SRC_DIR + 'scripts/main.js']
            }
        },
        copy: {
            build: {
                cwd: SRC_DIR,
                src: ['**', '!scripts/com/**/*.js', '!scripts/spec/**/*.js', '!scripts/e2e/**/*.js', '!styles/less/**'],
                dest: BUILD_DIR,
                expand: true
            }
        },
        concat: {
            options: {
                separator: ';'
            },
            modules: {
                src: [
                    SRC_DIR + 'scripts/com/app.js',
                    SRC_DIR + 'scripts/com/config.js',
                    SRC_DIR + 'scripts/com/**/*.js'
                ],
                dest: SRC_DIR + 'scripts/main.js'
            }
        },
        jshint: {
            all: [
                'Gruntfile.js',
                SRC_DIR + 'scripts/com/**/*.js',
                SRC_DIR + 'scripts/e2e/**/*.js',
                SRC_DIR + 'scripts/spec/**/*.js',
                'mock_server/**/*.js'
            ],
            options: {
                reporter: require('jshint-stylish'),
                globals: {
                    angular: true,
                    "_": true
                }
            }
        },
        less: {
            development: {
                options: {
                    cleancss: true
                },
                files: {
                    'src/styles/main.css': "src/styles/less/**/*.less"
                }
            }
        },
        jasmine: {
            module: {
                src: 'src/scripts/com/**/*.js',
                options: {
                    specs: 'src/scripts/spec/**/*Spec.js',
                    vendor: [
                        'vendor/scripts/angular.min.js',
                        'vendor/scripts/ui-utils.min.js',
                        'vendor/scripts/angular-route.min.js',
                        'vendor/scripts/angular-translate.min.js',
                        'vendor/scripts/angular-translate-loader-static-files.min.js',
                        'vendor/scripts/spec/angular-mocks.js'
                    ],
                    helpers: 'src/scripts/spec/helper/*.js'
                }
            }
        },
        protractor: {
            options: {
                configFile: "protractor.conf.js",
                keepAlive: false,
                noColor: false
            },
            your_target: {}
        }
    });

    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-less');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-clean');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-jasmine');
    grunt.loadNpmTasks('grunt-protractor-runner');

    grunt.registerTask('default', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'copy']);
    grunt.registerTask('compile', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'protractor', 'copy']);
    grunt.registerTask('unit-test', ['jshint', 'jasmine']);
    grunt.registerTask('e2e-test', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'protractor']);
};
