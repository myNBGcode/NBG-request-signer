# NBG Request Signer

## About
Windows Forms application for generating detached JWS from a json payload input.

## Executable file
The exe is in the [Executable folder](Executable/RequestSigner.exe).

## Usage

### Setup Config file
- Set the CertificatePath and CertificatePassword of the private .p12 file that will be used for generating the detached JWS signature.

### Generating the detached JWS
- Paste in the Request textbox the payload of the request that needs to be signed.
- Click generate signature.
- The detached JWS textbox will be filled. It can be copied and used as the **Signature** header in the request.

### Get TPP-Signature-Certificate from public certificate file
- Click Select Certificate File button.
- From the file picker that appears select the public certificate file.
- A base64 string will be filled in the above textbox. It can be used in the **TPP-Signature-Certificate** request header.

## Implementation
- The string is parsed as a json object and then serialized back to string, to make sure whitespaces and new lines are removed.
- Then using the output string we generate a JWS detached signature
