using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class MimicryObjectErrorMessage : SymbioticObjectErrorMessage
	{
		public const uint Id = 6461;

		public bool preview;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6461;
			}
		}

		public MimicryObjectErrorMessage()
		{
		}

		public MimicryObjectErrorMessage(sbyte reason, sbyte errorCode, bool preview) : base(reason, errorCode)
		{
			this.preview = preview;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.preview = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteBoolean(this.preview);
		}
	}
}