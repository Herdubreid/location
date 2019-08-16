const path = require('path');
const webpack = require('webpack');

module.exports = {
    context: path.join(__dirname, 'JS'),
    entry: './index.js',
    target: 'node',
    resolve: {
        alias: {
            jquery: 'jquery/src/jquery'
        },
        extensions: ['.tsx', '.ts', '.js']
    },
    plugins: [
        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery'
        })
    ],
    output: {
        path: path.join(__dirname, 'wwwroot', 'js'),
        filename: '[name].bundle.js',
        library: 'main'
    }
};
