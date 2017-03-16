using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class SymbioticObjectErrorMessage : ObjectErrorMessage
	{
		public const uint Id = 6526;

		public sbyte errorCode;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6526;
			}
		}

		public SymbioticObjectErrorMessage()
		{
		}

		public SymbioticObjectErrorMessage(sbyte reason, sbyte errorCode) : base(reason)
		{
			this.errorCode = errorCode;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.errorCode = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.errorCode);
		}
	}
}