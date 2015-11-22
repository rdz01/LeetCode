module.exports = function (grunt) {
    var NODE_MODULES_DIR = 'node_modules/';
    var SRC_DIR = 'src/';
    var PUBLISH_DIR = 'dist/';

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        clean: {
            prebuild: {
                src: [SRC_DIR + 'scripts/vendor/', SRC_DIR + 'styles/vendor/']
            }
        },
        copy: {
            vendorjs: {
                cwd: NODE_MODULES_DIR,
                src: [
                    'angular/angular.min.js',
                    'angular-animate/angular-animate.min.js',
                    'angular-aria/angular-aria.min.js',
                    'angular-material/angular-material.min.js'
                ],
                dest: SRC_DIR + 'scripts/vendor/',
                expand: true,
                flatten: true
            },
            vendorcss: {
                cwd: NODE_MODULES_DIR,
                src: [
                    'angular-material/angular-material.min.css'
                ],
                dest: SRC_DIR + 'styles/vendor/',
                expand: true,
                flatten: true
            },
            publish: {
                cwd: SRC_DIR,
                src: ['**', '!scripts/com/**/*.js', '!scripts/spec/**/*.js', '!scripts/e2e/**/*.js', '!styles/less/**'],
                dest: PUBLISH_DIR,
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
                SRC_DIR + 'scripts/spec/**/*.js'
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

    // grunt.loadNpmTasks('grunt-contrib-jshint');
    // grunt.loadNpmTasks('grunt-contrib-less');
    // grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-clean');
    grunt.loadNpmTasks('grunt-contrib-copy');
    // grunt.loadNpmTasks('grunt-contrib-jasmine');
    // grunt.loadNpmTasks('grunt-protractor-runner');

    // grunt.registerTask('default', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'copy']);
    grunt.registerTask('pre-build', ['clean:prebuild', 'copy:vendorjs', 'copy:vendorcss']);
    // grunt.registerTask('build', ['jshint', 'jasmine', 'less', 'concat', 'protractor', ]);
    // grunt.registerTask('unit-test', ['jshint', 'jasmine']);
    // grunt.registerTask('e2e-test', ['jshint', 'jasmine', 'clean', 'less', 'concat', 'protractor']);
};
